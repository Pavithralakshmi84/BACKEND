<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project_1.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Campus Selection System - Home</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: 'Arial', sans-serif;
            line-height: 1.6;
            color: #333;
        }

        /* Navigation */
        .navbar {
            background: #2c3e50;
            padding: 1rem 0;
            position: fixed;
            width: 100%;
            top: 0;
            z-index: 1000;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .nav-container {
            max-width: 1200px;
            margin: 0 auto;
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 0 2rem;
        }

        .logo {
            color: white;
            font-size: 1.8rem;
            font-weight: bold;
            text-decoration: none;
        }

        .nav-links {
            display: flex;
            list-style: none;
            gap: 2rem;
        }

        .nav-links a {
            color: white;
            text-decoration: none;
            font-weight: 500;
            transition: color 0.3s;
        }

        .nav-links a:hover {
            color: #3498db;
        }

        .btn {
            background: #3498db;
            color: white;
            padding: 0.7rem 1.5rem;
            border: none;
            border-radius: 5px;
            text-decoration: none;
            font-weight: 500;
            transition: all 0.3s;
            cursor: pointer;
        }

        .btn:hover {
            background: #2980b9;
            transform: translateY(-2px);
        }

        /* Hero Section */
        .hero {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            text-align: center;
            color: white;
            padding: 0 2rem;
        }

        .hero-content h1 {
            font-size: 3.5rem;
            margin-bottom: 1rem;
            animation: fadeInUp 1s ease;
        }

        .hero-content p {
            font-size: 1.3rem;
            margin-bottom: 2rem;
            animation: fadeInUp 1s ease 0.2s both;
        }

        .btn-group {
            display: flex;
            gap: 1rem;
            justify-content: center;
            flex-wrap: wrap;
            animation: fadeInUp 1s ease 0.4s both;
        }

        /* Sections */
        .section {
            padding: 80px 0;
            max-width: 1200px;
            margin: 0 auto;
        }

        .container {
            padding: 0 2rem;
        }

        .section-title {
            text-align: center;
            font-size: 2.5rem;
            margin-bottom: 3rem;
            color: #2c3e50;
        }

        .features {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 2rem;
            margin-top: 3rem;
        }

        .feature-card {
            background: white;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.1);
            text-align: center;
            transition: transform 0.3s;
        }

        .feature-card:hover {
            transform: translateY(-10px);
        }

        .feature-icon {
            font-size: 3rem;
            color: #3498db;
            margin-bottom: 1rem;
        }

        /* Stats */
        .stats {
            background: #f8f9fa;
            text-align: center;
        }

        .stats-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 2rem;
        }

        .stat-item h3 {
            font-size: 3rem;
            color: #3498db;
        }

        /* Contact */
        .contact {
            background: #2c3e50;
            color: white;
            text-align: center;
        }

        .contact-info {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 2rem;
            margin-top: 3rem;
        }

        .contact-item i {
            font-size: 2.5rem;
            color: #3498db;
            margin-bottom: 1rem;
        }

        /* Footer */
        .footer {
            background: #1a252f;
            color: white;
            text-align: center;
            padding: 2rem 0;
        }

        /* Animations */
        @keyframes fadeInUp {
            from {
                opacity: 0;
                transform: translateY(30px);
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }

        /* Responsive */
        @media (max-width: 768px) {
            .nav-links {
                display: none;
            }

            .hero-content h1 {
                font-size: 2.5rem;
            }

            .btn-group {
                flex-direction: column;
                align-items: center;
            }

            .section-title {
                font-size: 2rem;
            }
        }
    </style>
</head>
<body>
    <!-- Navigation -->
    <nav class="navbar">
        <div class="nav-container">
            <a href="#" class="logo">🎓 Campus Selection</a>
            <ul class="nav-links">
                <li><a href="Home.aspx">Home</a></li>
                <li><a href="StudentLogin.aspx">Students</a></li>
                <li><a href="CompanyLogin.aspx">Companies</a></li>
                <li><a href="new_job.aspx">New Company</a></li>
                <li><a href="#about">About</a></li>
                <li><a href="#contact">Contact</a></li>
            </ul>
            <a href="Admin.aspx" class="btn">Admin Login</a>
        </div>
    </nav>

    <!-- Hero Section -->
    <section id="home" class="hero">
        <div class="hero-content">
            <h1>Welcome to Campus Selection System</h1>
            <p>Connecting Top Talent with Leading Companies</p>
            <div class="btn-group">
                <a href="#" class="btn btn-student">Student Login</a>
                <a href="#" class="btn btn-company">Company Login</a>
            </div>
        </div>
    </section>

    <!-- Students Section -->
    <section id="students" class="section">
        <div class="container">
            <h2 class="section-title">For Students</h2>
            <div class="features">
                <div class="feature-card">
                    <div class="feature-icon">🔍</div>
                    <h3>Job Search</h3>
                    <p>Find thousands of jobs from top companies in your field</p>
                </div>
                <div class="feature-card">
                    <div class="feature-icon">📄</div>
                    <h3>Easy Apply</h3>
                    <p>Apply to jobs with just one click</p>
                </div>
                <div class="feature-card">
                    <div class="feature-icon">📊</div>
                    <h3>Track Progress</h3>
                    <p>Monitor your application status in real-time</p>
                </div>
            </div>
            <div style="text-align: center; margin-top: 3rem;">
                
            </div>
        </div>
    </section>

    <!-- Companies Section -->
    <section id="companies" class="section" style="background: #f8f9fa;">
        <div class="container">
            <h2 class="section-title">For Companies</h2>
            <div class="features">
                <div class="feature-card">
                    <div class="feature-icon">👥</div>
                    <h3>Talent Pool</h3>
                    <p>Access verified student profiles from top colleges</p>
                </div>
                <div class="feature-card">
                    <div class="feature-icon">🎯</div>
                    <h3>Advanced Filters</h3>
                    <p>Filter candidates by skills, CGPA, and experience</p>
                </div>
                <div class="feature-card">
                    <div class="feature-icon">💼</div>
                    <h3>Post Jobs</h3>
                    <p>Post unlimited jobs for free</p>
                </div>
            </div>
            <div style="text-align: center; margin-top: 3rem;">
                <a href="CompanyRegister.aspx" class="btn">Register Company</a>
            </div>
        </div>
    </section>

    <!-- Stats Section -->
    <section class="stats section">
        <div class="container">
            <div class="stats-grid">
                <div class="stat-item">
                    <h3>1,250+</h3>
                    <p>Students</p>
                </div>
                <div class="stat-item">
                    <h3>320+</h3>
                    <p>Companies</p>
                </div>
                <div class="stat-item">
                    <h3>850+</h3>
                    <p>Jobs Posted</p>
                </div>
            </div>
        </div>
    </section>

    <!-- About Section -->
    <section id="about" class="section">
        <div class="container">
            <h2 class="section-title">About Us</h2>
            <p style="text-align: center; font-size: 1.2rem; max-width: 800px; margin: 0 auto 3rem;">
                We bridge the gap between academic excellence and corporate opportunities, 
                ensuring students get the best career opportunities while companies access top talent.
            </p>
        </div>
    </section>

    <!-- Contact Section -->
    <section id="contact" class="contact section">
        <div class="container">
            <h2 class="section-title" style="color: white;">Contact Us</h2>
            <div class="contact-info">
                <div class="contact-item">
                    <i>📍</i>
                    <h3>Visit Us</h3>
                    <p>Chennai, Tamil Nadu<br>India - 600001</p>
                </div>
                <div class="contact-item">
                    <i>✉️</i>
                    <h3>Email</h3>
                    <p>support@campusselection.com</p>
                </div>
                <div class="contact-item">
                    <i>📞</i>
                    <h3>Call</h3>
                    <p>+91 12345 67890</p>
                </div>
            </div>
        </div>
    </section>

    <!-- Footer -->
    <footer class="footer">
        <div class="container">
            <p>&copy; 2026 Campus Selection System. All rights reserved.</p>
        </div>
    </footer>

    <script>
        // Smooth scrolling for navigation links
        document.querySelectorAll('a[href^="#"]').forEach(anchor => {
            anchor.addEventListener('click', function (e) {
                e.preventDefault();
                const target = document.querySelector(this.getAttribute('href'));
                if (target) {
                    target.scrollIntoView({
                        behavior: 'smooth',
                        block: 'start'
                    });
                }
            });
        });

        // Navbar scroll effect
        window.addEventListener('scroll', () => {
            const navbar = document.querySelector('.navbar');
            if (window.scrollY > 50) {
                navbar.style.background = 'rgba(44, 62, 80, 0.95)';
                navbar.style.backdropFilter = 'blur(10px)';
            } else {
                navbar.style.background = '#2c3e50';
                navbar.style.backdropFilter = 'none';
            }
        });
    </script>
</body>
</html>
