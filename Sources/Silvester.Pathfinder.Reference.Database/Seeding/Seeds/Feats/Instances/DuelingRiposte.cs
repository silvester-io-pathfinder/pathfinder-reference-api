using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelingRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("f465e042-fbb5-4a53-90c1-4cfc639987c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dueling Riposte",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach critically fails a Strike against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26dc125e-a7f0-4a68-9fc9-e9b440ccd00b"), Type = TextBlockType.Text, Text = "You riposte against your flailing enemy. Make a melee (action: Strike) against or attempt to (action: Disarm) the triggering creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e29bee0b-0b27-40ea-93bd-f1bd4ad95364"), Feats.Instances.DuelingParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c40a986b-afd0-4bd2-a89f-fa269e0a86ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
