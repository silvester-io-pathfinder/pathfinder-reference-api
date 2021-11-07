using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnchantingArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("254b2e8a-8be2-4bd6-bce0-17299e72b291");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enchanting Arrow",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2da780d-2de0-4043-8731-96cf90814ac7"), Type = TextBlockType.Text, Text = "With a single whisper carried on the wind, you enchant your ammunition to make a foe more vulnerable to your attacks. Make a bow (action: Strike). On a hit, the target takes an additional 2d6 mental damage. On a critical hit, the target also becomes stunned 1. The mental damage increases to 3d6 if your bow has a (item: greater striking rune | Greater Striking Runestone), or to 4d6 if your bow has a (item: major striking rune | Major Striking Runestone)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("81b11ab3-fda7-4d72-b2b2-6e4e725cae3b"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("448f2767-70f1-43e3-a4f8-cb69d2945d01"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
