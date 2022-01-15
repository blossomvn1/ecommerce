import React, { useState, useEffect } from 'react';
import { Menu, Button, Badge } from 'antd';
import { HomeOutlined, ShoppingCartOutlined, UserOutlined } from '@ant-design/icons';
import { Link, useNavigate } from 'react-router-dom';
import './header.css';

const { SubMenu } = Menu;
function AppHeader() {
	const [ current, setCurrent ] = useState('main');
	const navigate = useNavigate();
	const handleClick = (e) => {
		setCurrent(e.key);
	};

	function onClickLogin() {
		navigate('/login');
	}

	function onClickSignUp() {
		navigate('/signup');
	}
	const onClickCart = () => {
		navigate('/cart');
	};

	const onClickUpload = () => {
		navigate('/upload');
	};

	function onClickLogOut() {
		localStorage.removeItem('token');
	}
	return (
		<Menu onClick={handleClick} selectedKeys={[ current ]} mode="horizontal">
			<Menu.Item key="homepage" icon={<HomeOutlined />}>
				<a href="/">Homepage</a>
			</Menu.Item>
			<SubMenu key="SubMenu" title="Loại hàng hóa">
				<Menu.Item key="type:1">
					<a href="/op1">Option 1</a>
				</Menu.Item>
				<Menu.Item key="type:2">
					<a href="/op2">Option 2</a>
				</Menu.Item>
				<Menu.Item key="type:3">
					<a href="/op3">Option 3</a>
				</Menu.Item>
				<Menu.Item key="type:4">
					<a href="/op4">Option 4</a>
				</Menu.Item>
			</SubMenu>
			<SubMenu key="Driver" title="Tài xế" style={{ marginLeft: 10 }}>
				<Menu.Item key="4">
					<a href="/nearest_store">Tìm cửa hàng gần nhất</a>
				</Menu.Item>
				<Menu.Item key="5">
					<a href="/nearest_shipper">Tìm shipper gần nhất</a>
				</Menu.Item>
				<Menu.Item key="6">
					<a href="/get_order">Tiếp nhận đơn hàng</a>
				</Menu.Item>
			</SubMenu>
			{!localStorage.getItem('token') ? (
				<Menu.Item className="login-space">
					<Link to="/cart">Cart</Link>
					<Button className="login-button" type="primary" size="middle" onClick={onClickLogin}>
						Đăng nhập
					</Button>
					<Button className="signup-button" type="primary" size="middle" onClick={onClickSignUp}>
						Tạo tài khoản
					</Button>
				</Menu.Item>
			) : (
				<Menu.Item className="login-space">
					<SubMenu key="SubMenu" title={<UserOutlined style={{ fontSize: '150%' }} />}>
						<Menu.Item key="7">
							<a href="/profile">Trang cá nhân</a>
						</Menu.Item>
						<Menu.Item key="8">
							<a href="/regist-seller">Bắt đầu kinh doanh</a>
						</Menu.Item>
						<Menu.Item key="9">
							<a href="/register_driver">Đăng ký shipper</a>
						</Menu.Item>
						<Menu.Item key="10">
							<a href="/" onClick={onClickLogOut}>
								Đăng xuất
							</a>
						</Menu.Item>
					</SubMenu>
				</Menu.Item>
			)}
		</Menu>
	);
}

export default AppHeader;