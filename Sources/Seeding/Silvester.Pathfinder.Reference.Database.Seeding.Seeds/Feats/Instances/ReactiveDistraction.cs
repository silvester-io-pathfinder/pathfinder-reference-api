using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("1c71fd28-e4dc-4f6b-89b4-9b88f1f85929");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Distraction",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would be hit by an attack or targeted by an effect, or you are within an effect's area.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec9550e5-47b8-4c6e-9238-481c45125c59"), Type = TextBlockType.Text, Text = $"You reactively switch with your decoy to foil your foe. You use {ToMarkdownLink<Models.Entities.Feat>("Perfect Distraction", Feats.Instances.PerfectDistraction.ID)}, even if you were observed, as long as you end the movement of your {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} while concealed or in a location with cover or greater cover. Your decoy is targeted by the attack or effect instead of you. In the case of an area effect, if your {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} doesn't move you out of the area, both you and the decoy are targeted by the effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4f0a10d4-3f99-4777-8368-0638aa2622f7"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("4b89763d-c273-4681-afa1-5d99404a7ebc"), Feats.Instances.PerfectDistraction.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("565df436-a743-4d98-a7b3-88973974fe04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
