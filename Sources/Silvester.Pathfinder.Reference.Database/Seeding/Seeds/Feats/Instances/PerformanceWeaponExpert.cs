using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerformanceWeaponExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("6e064e21-901d-4f7e-8b16-408643a86191");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Performance Weapon Expert",
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
            yield return new TextBlock { Id = Guid.Parse("3deaf396-8c09-4ccb-b7ae-0800b9194e44"), Type = TextBlockType.Text, Text = "Your experience has made you better with a wide variety of weapons. Your proficiency ranks for simple weapons and martial weapons increase to expert, as does your proficiency rank for your chosen advanced weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("977f419e-4ffc-4d24-b66f-c0276f6eaa1e"), Feats.Instances.ProvocatorDedication.ID);
            builder.AddOr(Guid.Parse("f512ba1c-9c81-4cf3-80cf-3243a51f0587"), or => 
            {
                or.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("4d2aac13-6569-4099-b9f1-e5568c62b9f0"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyRangedWeaponSpecificProficiency(Guid.Parse("0f97ac36-5c5e-4a7b-9dd0-2a6bad3515ac"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("d5515085-be7c-4c39-9970-22694cb77041"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyWeaponGroupSpecificProficiency(Guid.Parse("9ab4841a-1d05-4963-8a8f-f7cc275f18c3"), Proficiencies.Instances.Expert.ID);
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
                Id = Guid.Parse("038eec31-8922-41e0-a0ce-deb7d0269584"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
