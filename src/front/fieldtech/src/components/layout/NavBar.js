import {Link} from 'react-router-dom'
import styles from './Navbar.module.css'

import Container from './Container'
import logo from '../img/logo.png'

function NavBar(){
    return (
      <nav class={styles.navbar}>
          <Container>
            <Link to="/"><img src={logo} alt="E-Soluções"/></Link>
               <ul className={styles.list} >
                <li className={styles.item} ><Link to="/">Home</Link></li>
                <li className={styles.item}><Link to="/field">Field</Link></li>
                <li className={styles.item}><Link to="/empresa">Empresa</Link></li>
                <li className={styles.item}><Link to="/contato">Contato</Link></li>
                </ul>
          </Container>
        </nav>

    )
}

export default NavBar