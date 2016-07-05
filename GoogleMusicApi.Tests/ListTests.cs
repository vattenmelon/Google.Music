﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using GoogleMusicApi.Common;
using GoogleMusicApi.Requests;
using GoogleMusicApi.Requests.Data;
using GoogleMusicApi.Structure;
using GoogleMusicApi.Structure.Enums;
using Rating = GoogleMusicApi.Structure.Enums.Rating;

namespace GoogleMusicApi.Tests
{
    [TestClass]
    public class ListTests
    {
        private readonly string _accountPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "account.txt");

        public Tuple<string, string> GetAccount()
        {
            if (!File.Exists(_accountPath))
            {
                Assert.Fail("account.txt file not found: " + _accountPath);
            }
            var file = File.ReadAllLines(_accountPath);
            return new Tuple<string, string>(file[0], file[1]);
        }

        [TestMethod]
        public async Task ListListenNowSituations()
        {
            var account = GetAccount();
            var mc = new MobileClient();
            Assert.IsTrue(await mc.LoginAsync(account.Item1, account.Item2));
            Assert.IsNotNull(await mc.ListListenNowSituationsAsync());
        }

        [TestMethod]
        public async Task ListListenNowTracks()
        {
            var account = GetAccount();
            var mc = new MobileClient();
            Assert.IsTrue(await mc.LoginAsync(account.Item1, account.Item2));
            Assert.IsNotNull(await mc.ListListenNowTracksAsync());
        }

        [TestMethod]
        public async Task ListPlaylists()
        {
            var account = GetAccount();
            var mc = new MobileClient();
            Assert.IsTrue(await mc.LoginAsync(account.Item1, account.Item2));
            Assert.IsNotNull(await mc.ListPlaylistsAsync());
        }

        [TestMethod]
        public async Task ListPromotedTracksAsync()
        {
            var account = GetAccount();
            var mc = new MobileClient();
            Assert.IsTrue(await mc.LoginAsync(account.Item1, account.Item2));
            Assert.IsNotNull(await mc.ListPromotedTracksAsync());
        }

        [TestMethod]
        public async Task ListStationCategories()
        {
            var account = GetAccount();
            var mc = new MobileClient();
            Assert.IsTrue(await mc.LoginAsync(account.Item1, account.Item2));
            Assert.IsNotNull(await mc.ListStationCategoriesAsync());
        }


    }
}