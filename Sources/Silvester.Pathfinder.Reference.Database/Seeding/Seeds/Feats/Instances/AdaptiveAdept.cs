using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdaptiveAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("d0ea8383-d129-48c9-88a2-574e028daa0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptive Adept",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b2f4210-af69-4430-859b-581869597d5f"), Type = TextBlockType.Text, Text = "You’ve continued adapting your magic to blend your class’s tradition with your adapted tradition. Choose a cantrip or 1st-level spell from the same magical tradition as your cantrip from (feat: Adapted Cantrip). You gain that spell, adding it to your spell repertoire, spellbook, or prepared spells just like the cantrip from (feat: Adapted Cantrip). You can cast this spell as a spell of your class’s magical tradition. If you choose a 1st-level spell, you don’t gain access to the heightened versions of that spell, meaning you can’t prepare them if you prepare spells and you can’t learn them or select the spell as a signature spell if you have a spell repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ecaae49-13df-4761-af6b-243d4ee99bcf"), Feats.Instances.AdaptedCantrip.ID);
            builder.HaveSpecificSpellSlotLevel(Guid.Parse("07948ece-98f3-4781-98ab-28af9c9f236f"), spellSlotLevel: 3);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("972a2ec6-d001-4087-895c-1b49479104c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
