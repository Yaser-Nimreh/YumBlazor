function ShowConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('BootstrapConfirmationModal')).show();
}

function HideConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('BootstrapConfirmationModal')).hide();
}