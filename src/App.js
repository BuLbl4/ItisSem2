import './App.css';
import React, { useState, useEffect } from 'react';
import CardPokemon from "./pages/details/index.jsx"

function App() {
  const [pokemonData, setPokemonData] = useState([]);

  useEffect(() => { 
    fetchKantoPokemon(); 
  }, []); 
 
 
  function fetchKantoPokemon() { 
    fetch('https://pokeapi.co/api/v2/pokemon?limit=100') 
      .then(response => response.json()) 
      .then(allpokemon => { 
        const promises = allpokemon.results.map(pokemon => fetchPokemonData(pokemon)); 
        Promise.all(promises) 
          .then(data => setPokemonData(data)) 
      }) 
  } 
 
  function fetchPokemonData(pokemon) { 
    let url = pokemon.url; 
    return fetch(url) 
      .then(response => response.json()) 
      .then(pokeData => { 
        console.log(pokeData); 
        return pokeData; 
      }); 
  }
  
  return (
    <>
    <div>
        {pokemonData.length === 0 ? (
          <p>Loading...</p>
        ) : (
          <Header allPokemonData={pokemonData} />
        )} {console.log(pokemonData)}
      </div> 
    </>
    
  );
}
      /*<CardPokemon />*/


const Header = ({ allPokemonData }) => {

  const [searchValue, setSearchValue] = useState('');
  const [filter, setFilter] = useState(allPokemonData); 

  const handleSearchClick = (e) => {
    setSearchValue(e.target.value);
    const lowercaseSearchValue = e.target.value.toLowerCase();

    const filterBratikov = allPokemonData.filter((pokemon) => pokemon.name
    .includes(lowercaseSearchValue));
    
    setFilter(filterBratikov);
  };
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
        <img src="magnifying-glass (1).png"  className="magnifying-glass" />
        <button type="button" className="go-button" onClick={handleSearchClick}> 
          Go
        </button>
      </div>

    </div>
      <div className='Card'>
        {filter.length === 0 && searchValue.length > 0 && (
          <div className='NoResult'>
            <h2>Oops! Try again.</h2>
            <span>The Pokemon you're looking for is a unicorn. It doesn't exist in this list</span>
            <img src="pika.png"/> 
          </div>
        )}
          {filter.map((pokemon, index) => (
            <PokemonCard key={index} pokemon={pokemon} />
          ))}
      </div>
    </>
  );
};


function PokemonCard({ pokemon }) {

  return (
    <>
      <div className="PokemonCard" onClick={ () => {
        alert("hello.")
      }}>
        <h6>{pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1)}</h6>
        <span>#{pokemon.id}</span>
        <img src={pokemon.sprites.other.home.front_default} />  
          <div  className='types'>
          {pokemon.types.map((type) => <Type type={type.type.name} />)}
          </div>

      </div>
    </>
  ); 
}

const Type = ({type}) => {
    return (
      <div className={type.toLowerCase()}>
        <label>{type.charAt(0).toUpperCase() + type.slice(1)}</label>
      </div>
    );
} 


export default App;
