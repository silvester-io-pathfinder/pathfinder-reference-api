using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DongunEducation : Template
    {
        public static readonly Guid ID = Guid.Parse("fdcdbee7-42c7-40b5-9dbe-7a641dbf6af6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dongun Education",
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
            yield return new TextBlock { Id = Guid.Parse("8e1d9692-6bb2-4623-8d2b-889440b68ab2"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("45b209eb-8dcd-4324-bb14-56ec09ff8d3f"), Type = TextBlockType.Text, Text = "You’re knowledgeable in trades that are important to your people’s survival and commercial interests. Pick two of the following Lore skills: Engineering Lore, Explosive Lore, or Firearm Lore. At 2nd level, you gain expert proficiency in these Lore skills; at 7th level, you gain master proficiency in these Lore skills; and at 15th level, you gain legendary proficiency in them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("741c401c-11b3-4314-8964-fcafe6ae7880"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
