using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ArcaneSenseFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("a6def9d1-3dd5-4d2f-8e75-1773753119d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Sense",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72e1ef9e-b124-40eb-b185-e1f6199d6c77"), Type = Utilities.Text.TextBlockType.Text, Text = "Your study of magic allows you to instinctively sense its presence. You can cast 1st-level detect magic at will as an arcane innate spell. If you’re a master in Arcana, the spell is heightened to 3rd level; if you’re legendary, it is heightened to 4th level." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d117552a-f149-48fd-8ff1-425893fb7b00"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID, RequiredSkillId = Skills.Instances.Arcana.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new InnateSpellEffect 
            {
                Id = Guid.Parse("d9c87bf6-f028-41db-a4ee-5c7c44808937"), 
                SpellId = Spells.Instances.DetectMagic.ID, 
                MagicTraditionId = MagicTraditions.Instances.Arcane.ID,
                Level = 1,
                Increments = new EffectIncrement[]
                {
                    new IncreaseLevelIncrement
                    {
                        Id = Guid.Parse("23b955d0-d4a9-45ff-a360-9e19de8eb6c4"),
                        Level = 3,
                        Trigger = new SkillProficiencyTrigger
                        {
                            Id = Guid.Parse("51ace397-c583-4391-a7de-37ae5bfa3052"),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            SkillId = Skills.Instances.Arcana.ID
                        }
                    },
                    new IncreaseLevelIncrement
                    {
                        Id = Guid.Parse("ab4b3a9e-5b97-47e0-a149-ef3af614be3e"),
                        Level = 4,
                        Trigger = new SkillProficiencyTrigger
                        {
                            Id = Guid.Parse("5b70f909-4e9e-4c18-92e5-0b1a1de8e518"),
                            ProficiencyId = Proficiencies.Instances.Legendary.ID,
                            SkillId = Skills.Instances.Arcana.ID
                        }
                    },
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4c7a663-d0eb-4d57-ae19-a76812543a31"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 258
            };
        }
    }
}
