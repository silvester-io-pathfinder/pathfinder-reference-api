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
    public class StrikersScroll : Template
    {
        public static readonly Guid ID = Guid.Parse("0f8697cf-09b7-4dff-8900-f985210eaaf9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Striker's Scroll",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9832927b-2869-4dfc-ae0f-95bbb8b67d55"), Type = TextBlockType.Text, Text = $"You can attach a scroll to your weapon or {ToMarkdownLink<Models.Items.Instances.WornItem>("handwraps of mighty blows", Items.WornItems.Instances.HandwrapsOfMightyBlows.ID)} to blend its spell into an attack, carefully folding it around a part of the weapon or sealing it to the weapon's surface. Attaching a scroll requires using the {ToMarkdownLink<Models.Entities.Action>("Affix a Talisman", Actions.Instances.AffixATalisman.ID)} action (Core Rulebook 565). You can have only one scroll affixed to a weapon at a time, and you can't have both a talisman and scroll attached." };
            yield return new TextBlock { Id = Guid.Parse("47bcbb4c-0098-432a-a95e-97306e761c50"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} from the scroll as part of a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}, assuming the spell is one you could normally use with {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}. You can't {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} in any other way while it's affixed, though you can use {ToMarkdownLink<Models.Entities.Action>("Affix a Talisman", Actions.Instances.AffixATalisman.ID)} again to remove the scroll and use it as a normal—if a bit crumpled—scroll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("83ac4585-5e0a-4abc-bf7f-da940f32529d"), Feats.Instances.Spellstrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("17b2ba6e-0275-415d-8898-8b3824bf8d13"), Traits.Instances.Magus.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a6799cf-2dc2-4c86-8888-4790757dfb66"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
