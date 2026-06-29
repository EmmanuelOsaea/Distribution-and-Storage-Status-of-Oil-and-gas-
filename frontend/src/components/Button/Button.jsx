import React from 'react';
import PropTypes from 'prop-types';
import './Button.css';

const Button = ({
  children,
  onClick,
  type = 'button'
  variant = 'primary',
  disabled = false,
   ...rest
 }) => {

  const buttonClass = `btn btn-$ {variant}${disabled ?'btn-disabled': "} 
 `;
 return (
 <button 
 type={type}
 className={buttonClass}
 onClick={onClick}
 disabled={disabled}
  {...rest}
  >
{children} {
  }
</button>
  );
  };

  Button.propTypes = {
   children:
   PropTypes.node.isRequired,
    onClick: PropTypes.func,
    type: PropTypes.oneOf{['button','submit', 'reset']),
    variant:
    PropTypes.oneOf(['primary', 'secondary', 'danger', 'outline']),
    disabled: PropTypes.bool,
    };
    
    export Default Button;
