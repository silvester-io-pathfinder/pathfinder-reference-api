using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonLore : Template
    {
        public static readonly Guid ID = Guid.Parse("3016c0e6-9c86-4d32-b563-a6ad1a57d02f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f02e9264-4f71-4c2c-90c5-fd4c60445cf2"), Type = TextBlockType.Text, Text = "You have come to better understand the process that made your body and the magic that powers it. You gain the trained proficiency rank in Arcana and Crafting. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Automaton Lore." };
            yield return new TextBlock { Id = Guid.Parse("1dcabca3-3feb-40c7-91fc-fb3e283ccabe"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("d4a117e4-4d15-4050-840b-5d778a41c56f"), Type = TextBlockType.Text, Text = "~ Enhancement: Your gain greater understanding. Increase your proficiency rank in either Arcana or Crafting, as well as Automaton Lore, to expert. If you were already an expert in the chosen skill, increase your rank to master instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82ab94ff-4e5f-43ed-bbcb-ce88e3e66700"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
