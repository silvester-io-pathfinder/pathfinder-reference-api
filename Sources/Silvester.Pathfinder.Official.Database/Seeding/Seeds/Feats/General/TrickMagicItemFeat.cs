using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class TrickMagicItemFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("219b84b9-cb31-44df-b37e-6bf4916e5dfb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trick Magic Item",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11d84471-94ee-4c1e-a67e-07c3ad92966e"), Type = Utilities.Text.TextBlockType.Text, Text = "You examine a magic item you normally couldn’t use in an effort to fool it and activate it temporarily. For example, this might allow a fighter to cast a spell from a wand or allow a wizard to cast a spell that’s not on the arcane list using a scroll. You must know what activating the item does, or you can’t attempt to trick it." };
            yield return new TextBlock { Id = Guid.Parse("6cd9c0c0-51e4-4c37-96d7-a7c861812b8e"), Type = Utilities.Text.TextBlockType.Text, Text = "Attempt a check using the skill matching the item’s magic tradition, or matching a tradition that has the spell on its list, if you’re trying to cast a spell from the item. The relevant skills are Arcana for arcane, Nature for primal, Occultism for occult, Religion for divine, or any of the four for an item that has the magical trait and not a tradition trait. The GM determines the DC based on the item’s level (possibly adjusted depending on the item or situation)." };
            yield return new TextBlock { Id = Guid.Parse("81d98c13-816a-41c5-9d33-476397d08dc7"), Type = Utilities.Text.TextBlockType.Text, Text = "If you activate a magic item that requires a spell attack roll or spell DC and you don’t have the ability to cast spells of the relevant tradition, use your level as your proficiency bonus and the highest of your Intelligence, Wisdom, or Charisma modifiers. If you’re a master in the appropriate skill for the item’s tradition, you instead use the trained proficiency bonus, and if you’re legendary, you instead use the expert proficiency bonus." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new OrPrerequisite
            {
                Id = Guid.Parse("8cbd0753-5757-4b8b-b134-4a9aa2196e79"),
                Choices =
                {
                    new SkillPrerequisite { Id = Guid.Parse("10ad44f9-e953-4e72-b4e0-72b6befed8d9"), RequiredSkillId = Skills.Instances.Arcana.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("984e1632-60e9-4775-a654-b0f11d2657ab"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("f818bf77-4277-406b-8dd7-175d11adbb58"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("3f40cd84-3265-437e-98a8-7b55c6583f0e"), RequiredSkillId = Skills.Instances.Religion.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                }
            };
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("14481cdc-273c-4a73-9c45-58d2db7309f4"),
                Success = "For the rest of the current turn, you can spend actions to activate the item as if you could normally use it.",
                Failure = "You can’t use the item or try to trick it again this turn, but you can try again on subsequent turns.",
                CriticalFailure = "You can’t use the item, and you can’t try to trick it again until your next daily preparations."
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Manipulate.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
