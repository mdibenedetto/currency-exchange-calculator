import React from 'react';

type ButtonConverterProps = {
    onClick: React.MouseEventHandler<HTMLButtonElement>
}

export const ButtonConverter = ({ onClick }: ButtonConverterProps) => (
    <button
        id="btnConvert"
        onClick={onClick}
    >
        Convert
    </button>
)