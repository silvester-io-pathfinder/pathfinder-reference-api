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
    public class SurreptitiousSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("3596a05b-be48-4e88-be93-83dedd71514c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surreptitious Spellcaster",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13859011-166c-40af-98f3-7f117cf34a6d"), Type = TextBlockType.Text, Text = $"You've learned that it pays for a Pathfinder to be able to cast spells without being noticed. You gain the {ToMarkdownLink<Models.Entities.Feat>("Conceal Spell", Feats.Instances.ConcealSpell.ID)} wizard class feat, though it's not a wizard feat for you. You also gain a +2 circumstance bonus to Stealth checks to {ToMarkdownLink<Models.Entities.Feat>("Conceal a Spell", Feats.Instances.ConcealSpell.ID)} and to Deception checks to conceal verbal components." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc141fae-6e5a-4c3a-b839-f8a3ef24c60f"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e2ae64f-ca49-4a30-abd4-ab61559d661d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
