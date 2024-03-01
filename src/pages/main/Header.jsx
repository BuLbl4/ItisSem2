import React, { useState, useEffect } from 'react';
import PokemonCard from './PokemonCard';
import axios from 'axios'

const Header = () => {
    
    const [pokemonData, setPokemonData] = useState([]);
    const [offset, setOffset] = useState(0);
    const [fetching, setFetching] = useState(true)
    const [allPokemon, setAllPokemon] = useState([])
    const [searchValue, setSearchValue] = useState('');
    const [filter, setFilter] = useState(allPokemon);

    useEffect(() => { 
        if(fetching){
            axios.get(`https://pokeapi.co/api/v2/pokemon?offset=${offset}&limit=49`)         
                .then(data => {
                    setPokemonData(prev => [...prev, ...data.data.results]);
                    setOffset(prev => prev + 49);
                })
                .finally(() => setFetching(false));
        }
    }, [fetching, offset]); 

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get('https://pokeapi.co/api/v2/pokemon?limit=1302');
                setAllPokemon(response.data.results);
            } catch (error) {
                console.log('There was an ERROR: ', error);
            }
        };
    
        fetchData(); // Вызываем функцию с асинхронным запросом
    }, []); // Передаем пустой массив зависимостей, чтобы эффект выполнился только при монтировании
    


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

    const handleSearchClick = (e) => {
        setSearchValue(e.target.value);
        const lowercaseSearchValue = e.target.value.toLowerCase();
        const filterBratikov = allPokemon.filter((pokemon) => pokemon.name
        .includes(lowercaseSearchValue))
        setFilter(filterBratikov);
    };

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
                    <img src="01 Poke Ball.png" className="pokeball" />
                    <input
                        placeholder="E.g. Pikachu"
                        type="text"
                        value={searchValue}
                        onChange={handleSearchClick}
                         />
                    <img src="magnifying-glass (1).png" className="magnifying-glass" />
                    <button type="button" className="go-button" onClick={handleSearchClick}>       
                        Go
                    </button>
                </div>
        
                </div><div className='Card'>
                    {filter.length === 0 && searchValue.length > 0 ? (
                            <div className='NoResult'>
                                <h2>Oops! Try again.</h2>
                                <span>The Pokemon you're looking for is a unicorn. It doesn't exist in this list</span>
                                <img src="pika.png" />
                            </div>
                        ) : (
                            filter.length > 0 && filter.length < 1300 ? (
                                filter.map((pokemon, index) => (
                                    <PokemonCard key={index} pokemon={pokemon.url} />
                                ))
                            ) : (
                                pokemonData.map((pokemon, index) => (
                                    <PokemonCard key={index} pokemon={pokemon.url} />
                                ))
                            )
                        )}  
                </div>
            </>
        )
    }
};

export default Header;