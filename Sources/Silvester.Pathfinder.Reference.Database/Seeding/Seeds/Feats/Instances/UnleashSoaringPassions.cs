using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashSoaringPassions : Template
    {
        public static readonly Guid ID = Guid.Parse("1fb163c8-4434-4cad-894a-a88c691d401c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Soaring Passions",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf934c4f-2208-40e4-b389-6e001d7a1612"), Type = TextBlockType.Text, Text = "Your power crests with each victory and ebbs with each setback." };
            yield return new TextBlock { Id = Guid.Parse("3ee154d1-7cae-4d1c-ba4e-7eed394e1238"), Type = TextBlockType.Text, Text = "~ Benefit: While this psyche is unleashed, if you succeed at a spell attack roll, you gain a +2 status bonus to your next spell attack roll, and if an enemy fails its save against your spell, it takes a –2 status penalty to the next save they attempt against one of your spells. This bonus or penalty lasts until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("22a425ef-ee7b-48aa-82e6-f4154203af4f"), Type = TextBlockType.Text, Text = "~ Drawback: While this psyche is Unleashed, when you fail at a spell attack roll, you take a –1 penalty to your next spell attack roll; if an enemy succeeds at its save against your spell, they gain a +1 status bonus to the next save they attempt against one of your spells. This penalty or bonus lasts until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c860954-3daf-4721-87c7-02822a78080f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
