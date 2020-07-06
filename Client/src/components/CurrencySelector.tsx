import React from 'react';
import { ICurrency } from '../model/ICurrency';

type CurrencySelectorProps =
    {
        id: string,
        label: string,
        currencyList: ICurrency[],
        defaultCurrencyValue: string,
        defaultAmountValue?: number,
        amountValue?: number,
        disabled?: boolean,
        onCurrencyChange: (value: string) => void,
        onAmountChange?: (value: number) => void,
    }


export const CurrencySelector = (
    {
        id,
        label,
        currencyList,
        defaultCurrencyValue,
        defaultAmountValue,
        amountValue,
        disabled = false,
        onCurrencyChange,
        onAmountChange = () => null,
    }: CurrencySelectorProps
) => (
        <>
            <label htmlFor={id}>{label}</label>
            <div className="form-control-group ">
                <select
                    id={id}
                    className="form-control"
                    defaultValue={defaultCurrencyValue}
                    onChange={(e: React.ChangeEvent<HTMLSelectElement>) => onCurrencyChange(e.target.value)}
                >
                    {
                        currencyList.map(currency => (
                            <option
                                key={currency.code}
                                value={currency.code}
                            >
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
                    defaultValue={defaultAmountValue}
                    value={amountValue}
                    onChange={(e: React.ChangeEvent<HTMLInputElement>) =>
                        onAmountChange(parseInt(e.target.value))}
                    className="money-amount form-control"
                />
            </div>
        </>
    );