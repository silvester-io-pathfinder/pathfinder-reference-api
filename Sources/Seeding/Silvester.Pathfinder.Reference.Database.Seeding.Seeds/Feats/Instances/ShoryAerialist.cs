using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoryAerialist : Template
    {
        public static readonly Guid ID = Guid.Parse("8f7b6d87-d15d-4793-a7a1-98135a6b615a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shory Aerialist",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48cede14-926c-4acb-ad60-28b11d18ea9d"), Type = TextBlockType.Text, Text = "~ Access: Garundi, Mauxi, or Tian-Yae ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("c8eb1a92-2ab0-4df8-9a25-9824a432f5da"), Type = TextBlockType.Text, Text = "Unique in Golarion's history, the Shory people developed fighting styles dedicated to combat in the air. You gain a +2 circumstance bonus to Acrobatics checks to (action: Maneuver in Flight) and a +5-foot status bonus to your fly Speed whenever you are flying via magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c62a885a-0b83-4dfe-aab9-d78465343053"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("4bf2cc5b-5752-4882-99eb-43933c13373b"), Feats.Instances.ShoryAeromancer.ID);
                or.HaveSpecificSpell(Guid.Parse("d13062f0-6d8f-4444-919e-3f7faf7fbf00"), Spells.Instances.Fly.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d266c287-5429-42bd-aa37-024c88c00d73"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
