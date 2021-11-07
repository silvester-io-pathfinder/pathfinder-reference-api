using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RoughTerrainStance : Template
    {
        public static readonly Guid ID = Guid.Parse("d1147b6a-4c8b-41c6-82f7-ea482f1c7f22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rough Terrain Stance",
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
            yield return new TextBlock { Id = Guid.Parse("db9ac528-d376-4188-b532-4600ec1ae9cb"), Type = TextBlockType.Text, Text = "You enter a stance that makes it difficult to move around you. Each square adjacent to you becomes difficult terrain that matches the terrain attunement you gained (rime forms in an arctic terrain, momentary undergrowth shoots up in a forest terrain, and so on). You ignore this difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("ef012120-941b-47c5-9cce-6f765a7970c9"), Type = TextBlockType.Text, Text = "This stance ends if you move into a different type of terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e3b10857-03c7-46ec-832f-6825624966d1"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("7566727c-b285-4899-a981-a2b01aa01402"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e87eaccb-0c00-4864-a96b-b1c49ed6911a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
