using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamExEF.Data;
using XamExEF.Models;

namespace XamExEF.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        public MockDataStore()
        {
            using var context = new XamExEFContext();
            if (context.Items.Any() == false)
            {
                context.Items.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description = "This is an item description." });
                context.Items.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description = "This is an item description." });
                context.Items.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description = "This is an item description." });
                context.Items.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description = "This is an item description." });
                context.Items.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description = "This is an item description." });
                context.Items.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description = "This is an item description." });
                context.SaveChanges();
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            using var context = new XamExEFContext();
            await context.Items.AddAsync(item);
            return (await context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            using var context = new XamExEFContext();
            context.Items.Update(item);
            return (await context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            using var context = new XamExEFContext();
            var item = context.Items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            context.Items.Remove(item);
            return (await context.SaveChangesAsync()) > 0;
        }

        public Task<Item> GetItemAsync(string id)
        {
            using var context = new XamExEFContext();
            return context.Items.FirstOrDefaultAsync(s => s.Id == id);
        }

        public Task<List<Item>> GetItemsAsync()
        {
            using var context = new XamExEFContext();
            return context.Items.ToListAsync();
        }
    }
}