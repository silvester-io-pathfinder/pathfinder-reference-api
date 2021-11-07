using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnchoringAura : Template
    {
        public static readonly Guid ID = Guid.Parse("09d3cedb-9b53-4250-8a9e-9e926df89c1f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anchoring Aura",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0c08a39f-e8ca-4d15-876d-d12b5eb3622d"), Type = TextBlockType.Text, Text = "Your aura hampers fiends’ teleportation. Your aura attempts to counteract (trait: teleportation) spells cast by fiends within 15 feet, using the spell level and DC of your devotion spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6e63522a-b19b-4cc8-83e9-fb35308a3713"), Feats.Instances.FiendsbaneOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e757c48-3c20-4079-a7f4-db0c623539ea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
