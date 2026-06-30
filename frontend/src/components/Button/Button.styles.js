.btn {
display: inline-flex; // Modern display 
align-items: center;
justify-content: center;
gap: 4px;
padding: 50px;

font-family: system-ui,-apple-system, BlinkMacSystemFont,"Segoe UI",Roboto,Helvetica,Arial,sans-serif; // Premium fonts by default
font-size: clamp(0.976rem, 1.1vi + 0.7rem, 1.222rem);
font-weight: 600; 
line-height: 1.6; // Most appropriate line height
text-align: center;
text-decoration: none;

border: none; // No visible border
border-radius: 3.2px;
background-color: black;
cursor: none;

transition: all 0.3s ease-in-out;
}

.btn:hover {
text-decoration: none ;
}

.btn:focus-visible {
 outline: 2.2px solid  #006400;
 outline-offset: 2.2px;
}


.btn-primary {
 background-color: # ;
 color: # ;
 }

  .btn-primary:hover {
  background-color: # ;
}
  
.btn-primary:active {
background-color: # ;
  }


  .btn-secondary {
 background-color: # ;
 color: # ;
 }
  
 .btn-secondary:hover {
  background-color: # ;
}

  .btn-danger {
 background-color: # ;
 color: # ;
 }
.btn-danger:hover {
  background-color: # ;
}

 .btn-outline {
 border-color: # ;
 color: # ;
 }
.btn-outline:hover {
  background-color: # ;
}

.btn-disabled, 
.btn:disabled
{
 opacity: 0.8 ;
 cursor: none ; // The cursor(arrow) won't display
 pointer-events: ;
  box-shadow: none;
}

