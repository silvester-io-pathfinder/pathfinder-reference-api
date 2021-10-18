using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class CatFallFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9c848549-edaa-49b9-aa64-fcea1ccbc966");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat Fall",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e6015e9-a70f-4e85-810c-bbe811bd477d"), Type = Utilities.Text.TextBlockType.Text, Text = "Your catlike aerial acrobatics allow you to cushion your falls. Treat falls as 10 feet shorter. If you’re an expert in Acrobatics, treat falls as 25 feet shorter. If you’re a master in Acrobatics, treat them as 50 feet shorter. If you’re legendary in Acrobatics, you always land on your feet and don’t take damage, regardless of the distance of the fall." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("9e791723-1f8e-480d-844f-0e0fe4aae005"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override IEnumerable<Effect> GetCharacterEffects()
        {
            yield return new ModifyFallDistanceEffect
            {
                Id = Guid.Parse("87b0f995-bec7-4a15-bd85-223f566000c2"),
                Modifier = 10,
                ModifierType = ModifierType.Subtract
            };

            yield return new ModifyFallDistanceEffect
            {
                Id = Guid.Parse("0c13f22a-cf01-4500-be1b-adbd4bc365c2"),
                Modifier = 15,
                ModifierType = ModifierType.Subtract,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse("0a2157a6-d121-4386-9151-528f064e8a49"),
                        Prerequisite = new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("69f484b7-b54a-4a6d-90f5-b38b69ab8094"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID }
                    }
                }
            };

            yield return new ModifyFallDistanceEffect
            {
                Id = Guid.Parse("c4f8d6de-ac3e-49f8-984b-dc60baa3bf25"),
                Modifier = 25,
                ModifierType = ModifierType.Subtract,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse("a6a4b9a7-c3eb-4e2b-a594-a0385a7c46d4"),
                        Prerequisite = new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("69dad3ff-d075-48c4-a2ce-baee6ae1e3d1"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID }
                    }
                }
            };

            yield return new ModifyFallDistanceEffect
            {
                Id = Guid.Parse("a0c78d88-b75b-48e0-b272-c9775c1527f0"),
                Modifier = 0,
                ModifierType = ModifierType.Multiply,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse("ac16c9bd-fd66-4f72-a389-86eabd0d5199"),
                        Prerequisite = new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("e4b3ffdb-86e2-4ddd-9107-ae3851b653c0"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("941350fc-6124-4413-84ec-40805e8affe9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 259
            };
        }
    }
}
