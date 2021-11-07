using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterVitalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("201ddd0a-9a49-4e92-969a-db5821834683");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Vital Evolution",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f741ada7-6516-422c-9798-3ac2c35c0411"), Type = TextBlockType.Text, Text = "Vital power surges through you like a font of energy. Twice per day, you can (activity: Cast a Spell) after you’ve run out of spell slots of the appropriate spell level; the two spells you cast with this feat must be of different spell levels." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("46205e9a-5b78-4b55-938f-2eb29453a637"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("36582c05-0f1f-4357-9144-ddb55ece58bd"), Feats.Instances.DivineEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("b109951f-7e4c-4a05-9cb1-5669536e2681"), Feats.Instances.PrimalEvolution.ID);
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
                Id = Guid.Parse("33451e46-b339-47cb-8a86-f685d5ccb485"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
