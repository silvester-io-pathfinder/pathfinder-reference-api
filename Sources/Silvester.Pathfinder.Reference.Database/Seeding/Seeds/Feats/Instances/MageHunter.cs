using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MageHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("5c3c5403-49f0-4119-9a81-35052c0f2dae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mage Hunter",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach Casts a Spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4dfaafed-c945-4bdd-b7af-a5ece91f2acd"), Type = TextBlockType.Text, Text = "You use your hatred of magic to lash out at the sight of spellcasting, allowing you to interrupt an enemy’s spell. Make a melee (action: Strike) against the triggering creature. If the attack is a critical hit, you disrupt the spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("8c4c0985-920e-44f0-9738-0debf52c8d97"), Instincts.Instances.Superstition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("948e2577-1c60-4da0-a26e-2ed924daa0a7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
