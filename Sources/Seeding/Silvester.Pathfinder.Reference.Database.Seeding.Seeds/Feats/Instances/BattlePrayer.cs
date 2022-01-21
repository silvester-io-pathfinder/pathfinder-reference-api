using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BattlePrayer : Template
    {
        public static readonly Guid ID = Guid.Parse("b27dddae-e7c1-45ad-ad93-515b858aa14f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Prayer",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21a4a8b3-40ac-43c0-9871-d35b4e011df3"), Type = TextBlockType.Text, Text = $"Calling out to your deity, you recite scripture to harm a foe. When you select this feat, choose {ToMarkdownLink<Models.Entities.Trait>("chaos", Traits.Instances.Chaotic.ID)}, {ToMarkdownLink<Models.Entities.Trait>("evil", Traits.Instances.Evil.ID)}, {ToMarkdownLink<Models.Entities.Trait>("good", Traits.Instances.Good.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("law", Traits.Instances.Lawful.ID)}. Your choice must match one of your deity's alignment components. This action has the trait corresponding to the chosen alignment." };
            yield return new TextBlock { Id = Guid.Parse("4751a97f-28fc-462d-ba5b-439ba696a187"), Type = TextBlockType.Text, Text = $"Attempt a Religion check against the Will DC of a foe within 30 feet. The foe is then temporarily immune to Battle Prayers from your deity for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e9f8a885-f169-4816-b740-86c85b7a6b7e"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("eba23c02-4852-4cb3-b95b-8a89bd2d264c"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("5c5c38c5-f16b-40ad-ab62-39a1e519c3ee"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("921bb0e9-42bf-44e8-b224-35093f0c1ef9"),
                CriticalSuccess = "You deal 2d6 damage of the chosen alignment type, or 6d6 damage if you have legendary proficiency in Religion.",
                Success = "You deal 1d6 damage of the chosen alignment type, or 3d6 damage if you have legendary proficiency in Religion.",
                Failure = "There is no effect.",
                CriticalFailure = "The backlash of your foe's will against your prayer prevents you from using Battle Prayer again for 10 minutes.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c00d117-3de8-4e61-b7b6-e66b01b3e130"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
