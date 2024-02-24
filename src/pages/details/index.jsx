import React, { useState, useEffect } from 'react';

function CardPokemon() {
    const [pokemonData, setPokemonData] = useState(null);

    useEffect(() => {
        fetch("https://pokeapi.co/api/v2/pokemon/4")
            .then(response => response.json())
            .then(pokemonData => {
                setPokemonData(pokemonData);
                console.log(pokemonData);
            });
    }, []);
    if(!pokemonData){
        return <div></div>
    }
    else{
        return (
            <>
            <h6>{pokemonData.id}</h6>
            <h6>{pokemonData.name}</h6>

            </>
        );
    }
    
}

export default CardPokemon;
