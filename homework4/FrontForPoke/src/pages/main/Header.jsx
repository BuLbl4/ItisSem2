import React, { useState, useEffect } from 'react';
import PokemonCard from './PokemonCard';
import axios from 'axios'
import pokeball from "../../Types/01 Poke Ball.png"
import glass from "../../Types/magnifying-glass (1).png"
import pika from "../../Types/pika.png"

const Header = () => {
    
    const [pokemonData, setPokemonData] = useState([]);
    const [offset, setOffset] = useState(0);
    const [fetching, setFetching] = useState(true)
    const [allPokemon, setAllPokemon] = useState([])
    const [searchValue, setSearchValue] = useState('');
    const [filter, setFilter] = useState(allPokemon);
    const [filterExecuted, setFilterExecuted] = useState(false);
    const [limit, setLimit] = useState(10); // Начальное значение для лимита



    useEffect(() => {
        if(fetching){
            console.log("Запрос 1")
            axios.get(`http://localhost:5022/api/Pokemon/Pagination?offset=${offset}&limit=${limit}`)
                .then(data => {
                    setPokemonData(prev => [...prev, ...data.data]);
                    setOffset(prev => prev + limit);
                    setLimit(prev => prev + limit)// Увеличиваем offset на значение limit
                })
                .finally(() => setFetching(false));
        }
    }, [fetching, offset]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                console.log("Zapros 2")

                const response = await axios.get('http://localhost:5022/api/Pokemon/GetAllPokemons');
                setAllPokemon(response.data);
            } catch (error) {
                console.log('ERROR: ', error);
            }
        };
    
        fetchData(); 
    }, []);
    
    useEffect(() =>{
        document.addEventListener('scroll', scrollHandler)

      return function(){
        document.removeEventListener('scroll', scrollHandler)
      }
    }, [])
   
   
    const scrollHandler = (e) => {
        if(e.target.documentElement.scrollHeight - (e.target.documentElement.scrollTop + window.innerHeight ) < 100){
            setFetching(true)
        }
    }

    useEffect(() => {
        if (searchValue === '') {
            setFilter([]);
        }
    }, [searchValue]);
    
    const handleSearchChange = (e) => {
        setSearchValue(e.target.value);
        setFilterExecuted(false);
    };
    const handleSearchClick = async () => {
        const lowercaseSearchValue = searchValue.toLowerCase();
        try {
            console.log(lowercaseSearchValue)
              const response = await axios.get(`http://localhost:5022/api/Pokemon/Filter/${lowercaseSearchValue}`);
              setFilter(response.data);
              setFilterExecuted(true);
              console.log(response.data)
        } catch (error) {
          console.log('ERROR: ', error);
        }
      };
    console.log(pokemonData)
    if(!pokemonData){
        return (
            <div></div>
        )
    } else {
        return (  
            <>
            <div className="Header">
                <div className="search-container">
                    <span>Who are you looking for?</span>
                    <img src={pokeball} className="pokeball" />
                    <input
                        placeholder="E.g. Pikachu"
                        type="text"
                        value={searchValue}
                        onChange={handleSearchChange}
                        />
                    <img src={glass} className="magnifying-glass" />
                    <button type="button" className="go-button" onClick={handleSearchClick}>       
                        Go
                    </button>
                </div>
        
                </div><div className='Card'>
                    {filterExecuted && filter.length === 0 && searchValue.length > 0 ? (
                        <div className='NoResult'>
                            <h2>Oops! Try again.</h2>
                            <span>The Pokemon you're looking for is a unicorn. It doesn't exist in this list</span>
                            <img src={pika} />
                        </div>
                    ) : (
                        filter.length > 0 ? (
                            filter.map((pokemon, index) => (
                                <PokemonCard key={index} pokemon={pokemon} />
                            ))
                        ) : (
                            pokemonData.map((pokemon, index) => (
                                <PokemonCard key={index} pokemon={pokemon} />
                            ))
                        )
                    )}
                </div>
            </>
        )
    }
};

export default Header;