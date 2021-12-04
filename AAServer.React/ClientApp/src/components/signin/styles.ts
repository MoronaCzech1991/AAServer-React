import styled from 'styled-components';

export const Container = styled.div`
  height: 400px;
  width: 500px;
  margin: 50px;
  border-radius: 5px;
  border: 2px, solid;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  background-color: #d7d2cb;
  box-shadow: 5px 5px 10px grey;
`;

export const Input = styled.input`
  padding: 10px;
  width: 350px;
  height: 40px;
  border: none;
  background: #f2f1f0;
  border-radius: 3px;
  margin: 10px;
`;

export const Button = styled.button`
  padding: 10px;
  width: 360px;
  height: 50px;
  border: none;
  border-radius: 8px;
  background: ${(props) => (props.color ? 'palevioletred' : '#2D2926')};
  color: #f2f1f0;
  margin: 10px;
  font-weight: bold;
`;

export const Title = styled.p`
  margin-bottom: 50px;
  font-weight: bold;
  color: #2d2926;
  font-size: 22px;
`;
