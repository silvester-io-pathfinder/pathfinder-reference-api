using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterVitalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("90a968fc-ba05-4d4e-9f84-34918593c81d");

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
            yield return new TextBlock { Id = Guid.Parse("0a3fa434-b35a-4578-9225-0121306cbf90"), Type = TextBlockType.Text, Text = "Vital power surges through you like a font of energy. Twice per day, you can (activity: Cast a Spell) after you’ve run out of spell slots of the appropriate spell level; the two spells you cast with this feat must be of different spell levels." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("4ece1dd1-e381-4d1e-b934-a7b62ce99f32"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("aec8edf4-340c-4a6d-b11e-52f60f3cfc66"), Feats.Instances.DivineEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("813d4cf4-552b-4935-af26-e1a580c4615f"), Feats.Instances.PrimalEvolution.ID);
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
                Id = Guid.Parse("8b96db14-f862-4be3-9a22-6ef2b33e88b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
