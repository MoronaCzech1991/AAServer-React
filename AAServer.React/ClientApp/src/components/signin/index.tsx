import React, { useState } from 'react';

import * as S from './styles';

const SignIn = () => {
  const [email, setEmail] = useState('');
  const [pass, setPassword] = useState('');

  return (
    <S.Container>
      <S.Title>Welcome, AAServer!</S.Title>
      <S.Input
        type="email"
        placeholder="E-mail / User Name "
        value={email}
        onChange={(e) => setEmail(e.target.value)}
      />
      <S.Input
        type="password"
        placeholder="Password"
        value={pass}
        onChange={(e) => setPassword(e.target.value)}
      />
      <S.Button> Sign-In </S.Button>
    </S.Container>
  );
};

export default SignIn;
