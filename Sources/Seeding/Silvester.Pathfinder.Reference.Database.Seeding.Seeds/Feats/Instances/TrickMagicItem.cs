using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickMagicItem : Template
    {
        public static readonly Guid ID = Guid.Parse("7c015244-fd92-4db2-b90c-d3a93fca76d2");

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
            yield return new TextBlock { Id = Guid.Parse("ef950b13-3352-41a7-a7fb-c32d444547ee"), Type = TextBlockType.Text, Text = $"You examine a magic item you normally couldn't use in an effort to fool it and activate it temporarily. For example, this might allow a fighter to cast a spell from a wand or allow a wizard to cast a spell that's not on the arcane list using a scroll. You must know what activating the item does, or you can't attempt to trick it." };
            yield return new TextBlock { Id = Guid.Parse("efbf536a-18e4-4e1b-9ed2-17ce878ec9c4"), Type = TextBlockType.Text, Text = $"Attempt a check using the skill matching the item's magic tradition, or matching a tradition that has the spell on its list, if you're trying to cast a spell from the item. The relevant skills are Arcana for arcane, Nature for primal, Occultism for occult, Religion for divine, or any of the four for an item that has the magical trait and not a tradition trait. The GM determines the DC based on the item's level (possibly adjusted depending on the item or situation)." };
            yield return new TextBlock { Id = Guid.Parse("a2b5182b-fd3e-4c97-b0c6-59ee8389c897"), Type = TextBlockType.Text, Text = $"If you activate a magic item that requires a spell attack roll or spell DC and you don't have the ability to cast spells of the relevant tradition, use your level as your proficiency bonus and the highest of your Intelligence, Wisdom, or Charisma modifiers. If you're a master in the appropriate skill for the item's tradition, you instead use the trained proficiency bonus, and if you're legendary, you instead use the expert proficiency bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("9104ab7a-6fe6-48bf-b60d-a19490d4056a"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("3d2a64a9-dab6-4a17-8695-5ed5684bc822"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("fda9b748-c36a-49fc-b342-ed66bf8ae27d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("a707265a-9998-442b-bcad-400364455322"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("af9e15a9-ba71-4297-822a-bfc2d6b48e02"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("9671aef1-3976-44df-b5e5-f840341af232"),
                
                Success = "For the rest of the current turn, you can spend actions to activate the item as if you could normally use it.",
                Failure = "You can't use the item or try to trick it again this turn, but you can try again on subsequent turns.",
                CriticalFailure = "You can't use the item, and you can't try to trick it again until your next daily preparations.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("873a3412-0c9b-4a8f-bd25-68092decae97"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
