function scrollToTop() {
    const anchor = document.getElementById('topAnchor');
    if (anchor) {
        anchor.scrollIntoView({ behavior: 'smooth', block: 'start' });
    }
}
