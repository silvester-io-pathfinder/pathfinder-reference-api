using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickMagicItem : Template
    {
        public static readonly Guid ID = Guid.Parse("5b2e34a4-a11c-4d6f-9d16-4e4a7db89675");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trick Magic Item",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93ca78db-ef35-44ba-9204-1becfe0cba9d"), Type = TextBlockType.Text, Text = "You examine a magic item you normally couldn’t use in an effort to fool it and activate it temporarily. For example, this might allow a fighter to cast a spell from a wand or allow a wizard to cast a spell that’s not on the arcane list using a scroll. You must know what activating the item does, or you can’t attempt to trick it." };
            yield return new TextBlock { Id = Guid.Parse("5777608f-a06c-4e3b-92dd-541854e7042c"), Type = TextBlockType.Text, Text = "Attempt a check using the skill matching the item’s magic tradition, or matching a tradition that has the spell on its list, if you’re trying to cast a spell from the item. The relevant skills are Arcana for arcane, Nature for primal, Occultism for occult, Religion for divine, or any of the four for an item that has the magical trait and not a tradition trait. The GM determines the DC based on the item’s level (possibly adjusted depending on the item or situation)." };
            yield return new TextBlock { Id = Guid.Parse("7bffcecc-b921-4e1b-8816-aa118becf4f0"), Type = TextBlockType.Text, Text = "If you activate a magic item that requires a spell attack roll or spell DC and you don’t have the ability to cast spells of the relevant tradition, use your level as your proficiency bonus and the highest of your Intelligence, Wisdom, or Charisma modifiers. If you’re a master in the appropriate skill for the item’s tradition, you instead use the trained proficiency bonus, and if you’re legendary, you instead use the expert proficiency bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("36ae7e1a-3715-4994-8631-65ffb34746cd"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("d6f66c10-416e-43d2-bc83-28bea10b4a71"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("38073094-3afb-4f4e-b950-76255b27834e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("e1bd4488-8229-4d59-a685-6dfc3ac5f48f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("f8794929-6ecd-42a8-abae-0c252c3ba8d1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("abb0bfc4-bd89-4eb5-88be-4483f06d009d"),
                
                Success = "For the rest of the current turn, you can spend actions to activate the item as if you could normally use it.",
                Failure = "You can’t use the item or try to trick it again this turn, but you can try again on subsequent turns.",
                CriticalFailure = "You can’t use the item, and you can’t try to trick it again until your next daily preparations.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f32f0d0e-9070-4b18-86b7-bfc0762c1529"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
