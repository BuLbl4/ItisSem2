import './details.css'
import TypeCard from './TypeCard';


function Moves({moveName}) {
    return (
        <>
        <div className='Moves'>
            <text>Moves</text>
            <div className='moves-container'>
                <div className="moves-list">
                    {moveName.moves.slice(0, 3).map((move, index) => (
                        <TypeCard key={index} typeName={move} name={moveName.name}/>
                    ))}  
                </div>
                <div className="moves-list">
                    {moveName.moves.slice(3, 6).map((move, index) => (
                        <TypeCard key={index} typeName={move} name={moveName.name}/>
                    ))}  
                </div>
            </div>
               
        </div>       
        </>
    );    
}

export default Moves;