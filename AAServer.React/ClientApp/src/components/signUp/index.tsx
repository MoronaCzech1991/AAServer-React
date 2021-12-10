import React, { useState } from 'react';

import * as S from './styles';

const SignUp = () => {
  const [email, setEmail] = useState('');
  const [pass, setPassword] = useState('');

  return (
    <S.Container>
      <S.Header>
        <S.Title>Sign-Up</S.Title>
      </S.Header>
      <S.Content>
        <S.Input
          type="name"
          placeholder="Name"
          value={pass}
          onChange={(e) => setPassword(e.target.value)}
        />
        <S.Input
          type="surname"
          placeholder="Surname"
          value={pass}
          onChange={(e) => setPassword(e.target.value)}
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
          value={pass}
          onChange={(e) => setPassword(e.target.value)}
        />
        <S.Input
          type="password"
          placeholder="Confirm Password"
          value={pass}
          onChange={(e) => setPassword(e.target.value)}
        />
        <S.Button> Sign-Up </S.Button>
      </S.Content>
    </S.Container>
  );
};

export default SignUp;
