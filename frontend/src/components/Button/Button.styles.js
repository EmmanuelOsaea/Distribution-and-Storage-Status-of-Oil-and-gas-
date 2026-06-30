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
 background-color: #2563eb;
 color: #f6f3e8;
 }

  .btn-primary:hover {
  background-color: #90A4B5;
}
  
.btn-primary:active {
background-color: #2e7d32;
  }


  .btn-secondary {
 background-color: #341539;
 color: #f6f3e8;
 }
  
 .btn-secondary:hover {
  background-color: #374151;
}

  .btn-danger {
 background-color: #dc9926;
 color: #f6f3e8;
 }
.btn-danger:hover {
  background-color: #dc2660;
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

