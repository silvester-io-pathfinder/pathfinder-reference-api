using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InnerFire : Template
    {
        public static readonly Guid ID = Guid.Parse("4de35568-a37a-49c5-b6cd-12b05a586327");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inner Fire",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("760a0309-884b-4e08-8fe4-5fa892060491"), Type = TextBlockType.Text, Text = "While you’re in Stoked Flame Stance, you have cold and fire resistance equal to half your level, and any creature that hits you with an unarmed attack, tries to Grab or (action: Grapple) you, or otherwise touches you takes fire damage equal to your Wisdom modifier (minimum 1). A creature can take this damage no more than once per turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("88065fe5-ad97-4a1a-b3d6-1021145faf06"), Feats.Instances.StokedFlameStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00ae405f-8f04-41c8-a841-9b6fedd97804"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
