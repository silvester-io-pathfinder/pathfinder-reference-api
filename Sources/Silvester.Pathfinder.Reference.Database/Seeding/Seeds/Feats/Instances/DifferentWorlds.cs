using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DifferentWorlds : Template
    {
        public static readonly Guid ID = Guid.Parse("dcd90e7e-f5a4-4be8-b9bb-4fdbc6465599");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Different Worlds",
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
            yield return new TextBlock { Id = Guid.Parse("a8104626-f4aa-44fa-91b3-0d053a03640b"), Type = TextBlockType.Text, Text = "~ Access: Have earnt Mialari Docur’s trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("3248b79e-e823-46cd-917e-c796a884fbe1"), Type = TextBlockType.Text, Text = "Your separate experiences in different societies have evolved into entirely separate lives. Create a second identity for yourself with a different name, history, and background. This identity must correspond to one of the ancestries whose ancestry feats you can select. You gain the trained proficiency rank in the Lore skill from the second background you chose (but you don’t gain any of the background’s other benefits), and you gain a +4 circumstance bonus to Deception checks when making a statement that would be true of your second identity or when disguising yourself as your second identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAncestryAmount(Guid.Parse("4f67d5c1-10f9-42d8-969d-1d4fa032cb9e"), Comparator.GreaterThanOrEqualTo, amount: 2);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86ad51b8-cdd2-414d-a981-c3ca90674bd2"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
