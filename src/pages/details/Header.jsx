import { Link } from "react-router-dom";
import './details.css'

const Header = () => {     
return (  
    <>
    <div className="head">
        <img src="../../Types/01 Poke Ball.png" className="pokeball"></img>
        <Link to={`/OrisSem2`}>
            <img src="../../Types/arrow-left.svg" className='arrow'></img>
        </Link>

    </div>
    </>
)};

  


  export default Header;