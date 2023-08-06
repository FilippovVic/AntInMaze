mergeInto(LibraryManager.library, {
  ShowAdv : function() {
    SendMessage('Sound', 'Configure', 0);
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          // some action after close
          SendMessage('Sound', 'Continue', 1);
        },
        onError: function(error) {
          // some action on error
        }
    }
  })
  },
});