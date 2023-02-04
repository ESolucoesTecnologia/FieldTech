import {FaEnvelope, FaInstagram, FaWhatsapp} from 'react-icons/fa'
import styles from './Footer.module.css'
function Footer() {
    return(
      <footer className={styles.footer}>
        <ul className={styles.social_list}>        
          <li><FaInstagram></FaInstagram></li>
          <li><FaWhatsapp></FaWhatsapp></li>
          <li><FaEnvelope></FaEnvelope></li>
        </ul>      
        <p className={styles.copy_right}>
          <span>E-Soluções - Field Tech</span> &copy; 2023</p>
      </footer>
    ) 
  }  
  export default Footer