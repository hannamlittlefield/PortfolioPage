#navbar {
  overflow: hidden;
  background-color: #4F345A;
  font-family: 'Rancho', cursive;
  font-size: 30px;
  position: fixed;
  top: 0;
  width: 100%;
}

a{
text-decoration: none;
}

#navbar a {
  float: right;
  display: block;
  color: #f2f2f2;
  text-align: center;
  padding: 14px;
  text-decoration: none;
}

#navbar a:hover {
  background-color: #5D4E6D;
}

.content {
  padding: 16px;
}

#welcome-section{
  text-align: center;
  background-color: #9CBFA7;
  font-family: 'Rancho', cursive;
  font-size: 30px;
  display: flex;
  flex-direction: column;
  padding-top: 0px;
  margin-top: 55px;
  display: block;
  height: 100vh;
}

#prof-photo { 
  margin: auto;
  width: 400px;
  border-radius: 50%;}

#projects{
  background-color: #C9F299;
  font-family: 'Rancho', cursive;
  font-size: 40px;
  text-align: center;
}
.project-tile{
  
  
}

#profile-link {
  }

#contact{
  background-color: #9CBFA7;
  font-family: 'Rancho', cursive;
  font-size: 40px;
  text-align: center;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-decoration: none;
  margin: 5px;
  flex-grow: 2;
}

#contact-container {
  display: flex;
  flex-flow: row wrap;
  justify-content: space-between;
  margin-bottom: 20px;
}

#contact-container a {
  color: #5D4E6D;
}
#contact-container a:hover {
  color: #C9F299;
}

@media(max-width:320px){  
  nav{
    font-size:1em;
    height: auto;
    max-height: 200px;
  }