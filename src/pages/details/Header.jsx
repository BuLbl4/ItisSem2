import { Link } from "react-router-dom";
import './details.css'

const Header = () => {     
return (  
    <>
    <div className="head">
        <img src="../01 Poke Ball.png" className="pokeball"></img>
        <Link to={`/`}>
            <img src="../arrow-left.svg" className='arrow'></img>
        </Link>

    </div>
    </>
)};

  


  export default Header;