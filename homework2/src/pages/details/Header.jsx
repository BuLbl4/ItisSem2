import { Link } from "react-router-dom";
import './details.css'
import arrow from "../../Types/arrow-left.svg"
import pokeball from "../../Types/01 Poke Ball.png"

const Header = () => {     
return (  
    <>
    <div className="head">
        <img src={pokeball} className="pokeball"></img>
        <Link to={`/OrisSem2`}>
            <img src={arrow} className='arrow'></img>
        </Link>

    </div>
    </>
)};

  


  export default Header;