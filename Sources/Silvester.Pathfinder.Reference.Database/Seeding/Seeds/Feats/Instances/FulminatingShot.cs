using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FulminatingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("21a22fe0-8341-46b9-91f1-22f68516ccf6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fulminating Shot",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round."
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8fbc622-f1c7-4743-bbda-ad7a76501216"), Type = TextBlockType.Text, Text = "You channel potent magic into your next shot, empowering it with a blast of crackling energy. Choose acid, cold, electricity, or fire. If you hit with your next attack roll using a firearm or crossbow before the end of your turn, you deal 1d6 additional damage of this type. At 12th level, this increases to 2d6 additional damage, and at 18th level, it increases to 3d6 additional damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("97179a50-9c90-44da-8e13-d04c3bbe317d"), Feats.Instances.SpellshotDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3aacd743-0cfe-4fbb-93a9-aaf78550ef42"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
