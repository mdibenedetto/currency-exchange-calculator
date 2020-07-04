import React from 'react';
import { ICurrency } from '../model/ICurrency';

type CurrencySelectorProps =
    {
        id: string,
        label: string,
        currencyList: ICurrency[],
        defaultValue?: string,
        clazz?: string,
        disabled?: boolean
    }


export const CurrencySelector = (
    {
        id,
        label,
        currencyList,
        clazz = "",
        defaultValue = "1",
        disabled = false
    }: CurrencySelectorProps
) => (
        <>
            <label htmlFor={id}>{label}</label>
            <div className="form-control-group ">
                <select id={id} className="form-control">
                    {
                        currencyList.map(currency => (
                            <option
                                key={currency.code}
                                value={currency.code}>
                                {currency.desc}
                            </option>
                        ))
                    }
                </select>
                <input

                    type="number"
                    min="0"
                    autoFocus
                    disabled={disabled}
                    defaultValue={defaultValue}
                    className="money-amount form-control"
                />
            </div>
        </>
    );