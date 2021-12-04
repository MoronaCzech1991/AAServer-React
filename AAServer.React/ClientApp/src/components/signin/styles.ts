import styled from 'styled-components';

export const Container = styled.div`
  margin: 50px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
`;

export const Input = styled.input`
  padding: 15px;
  width: 350px;
  height: 40px;
  border: none;
  background: #ecf0f1;
  border-radius: 3px;
  margin: 10px;
`;

export const Button = styled.button`
  padding: 10px;
  width: 360px;
  height: 50px;
  border: none;
  border-radius: 8px;
  background: ${(props) => (props.color ? 'palevioletred' : '#9A8F97')};
  color: #fff;
  margin: 10px;
  font-weight: bold;
`;

export const Title = styled.p`
  font-weight: bold;
  color: #9a8f97;
  font-size: 22px;
`;
