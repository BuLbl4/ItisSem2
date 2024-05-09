import './details.css'
import React, { useState, useEffect } from 'react';
import { useParams } from "react-router-dom";
import Header from './Header';
import Breeding from './Breeding';
import axios from 'axios'


function CardPokemon() {
    const [pokemonData, setPokemonData] = useState(null);
    const {name} = useParams();

    useEffect(() => {
        const fetchData = async () => {
            const response = await axios.get(`http://localhost:5022/api/Pokemon/ByName/${name}`);
            console.log(response.data, "HUI")
            setPokemonData(response.data);
        };
        fetchData();
      }, []);

    if(!pokemonData){
        return <div></div>
    }
    else{
        return (
            <>
            <Header></Header>
            <div className='Pokemon-stats'>
                <span>#{pokemonData.order}</span>
                <h6>{pokemonData.name.charAt(0).toUpperCase() + pokemonData.name.slice(1)}</h6>
                <div className='stats'>
                    <text>HP</text>
                    <div className="main-stats">
                        <div className="hp"></div>
                        <div style={{width: pokemonData.stat[0].value + 'px'}} className="hp-stat"></div>
                    </div>
                    
                    <text>Attack</text>
                    <div className="main-stats">
                        <div className="attack"></div>
                        <div style={{width: pokemonData.stat[1].value + 'px'}} className="attack-stat"></div>
                    </div>

                    <text>Defense</text>
                    <div className="main-stats">
                        <div className="defense"></div>
                        <div style={{width: pokemonData.stat[2].value + 'px'}} className="defense-stat"></div>
                    </div>
                    
                    <text>Speed</text>
                    <div className="main-stats">
                        <div className="speed"></div>
                        <div style={{width: pokemonData.stat[3].value + 'px'}} className="speed-stat"></div>
                    </div>
                    </div>
                        <div className='forImage'>
                        <div  className='type'>
                            {pokemonData.typesList.map((type) => <Type type={type} />)}
                        </div>
                            <img src={pokemonData.imgUrl}></img>
                            
                    </div>
                    
            </div>
            <Breeding pokemonData={pokemonData}/>
            </>
        );
    }
    
}
const Type = ({type}) => {
    console.log(type)
    return (
      <div className={type.toLowerCase()}>
        <label>{type.charAt(0).toUpperCase() + type.slice(1)}</label>
      </div>
    );
}

export default CardPokemon;
