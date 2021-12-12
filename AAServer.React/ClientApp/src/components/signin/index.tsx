import React, { SyntheticEvent, useState } from 'react';

import * as S from './styles';

const SignIn = () =>{
    const [email, setEmail] = useState('');
    const [passWord, setPassword] = useState('');

    const Submit = async (e: SyntheticEvent) =>
    {
        e.preventDefault();
        await fetch("https://localhost:5001/Login/Autenticate",
        {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            credentials: 'include',
            body: JSON.stringify({ email, passWord })
        });
    }

    return(
        <S.Container>
            <S.Header>
                <S.Title>Sign-In</S.Title>
            </S.Header>
            <S.Content>
                <S.Input
                    type="email"
                    placeholder="E-mail"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                />
                <S.Input
                    type="password"
                    placeholder="Password"
                    value={passWord}
                    onChange={(e) => setPassword(e.target.value)}
                />
                <S.Button onClick={Submit}> Sign-In </S.Button>
            </S.Content>
        </S.Container>
    );
};

export default SignIn;
