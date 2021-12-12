import React, { useState } from 'react';

import * as S from './styles';

const SignUp = () => {
  const [name, setName] = useState('');
  const [surname, setSurname] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [repeatPassword, setRepeatPassword] = useState('');

  return (
    <S.Container>
      <S.Header>
        <S.Title>Sign-Up</S.Title>
      </S.Header>
      <S.Content>
        <S.Input
          type="name"
          placeholder="Name"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        <S.Input
          type="surname"
          placeholder="Surname"
          value={surname}
          onChange={(e) => setSurname(e.target.value)}
        />
        <S.Input
          type="email"
          placeholder="E-mail"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        <S.Input
          type="password"
          placeholder="Password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <S.Input
          type="password"
          placeholder="Confirm Password"
          value={repeatPassword}
          onChange={(e) => setRepeatPassword(e.target.value)}
        />
        <S.Button> Sign-Up </S.Button>
      </S.Content>
    </S.Container>
  );
};

export default SignUp;
