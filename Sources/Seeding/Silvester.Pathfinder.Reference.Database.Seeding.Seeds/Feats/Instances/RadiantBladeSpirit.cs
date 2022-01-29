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
    public class RadiantBladeSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("c4641b03-743b-476f-b53e-9f158e3bc3d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Blade Spirit",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb0d66c5-2890-4643-936a-0229c8a13040"), Type = TextBlockType.Text, Text = $"Your divine ally radiates power, enhancing your chosen weapon. When you choose the weapon for your blade ally during your daily preparations, add the following property runes to the list of effects you can choose from: {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("flaming", Items.WeaponPropertyRunes.Instances.Flaming.ID)} and any aligned properties ({ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("anarchic", Items.WeaponPropertyRunes.Instances.Anarchic.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("axiomatic", Items.WeaponPropertyRunes.Instances.Axiomatic.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("holy", Items.WeaponPropertyRunes.Instances.Holy.ID)}, or {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("unholy", Items.WeaponPropertyRunes.Instances.Unholy.ID)}) that match your cause's alignment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("766ef03d-c781-43cc-820d-425c6ab6f132"), DivineAllies.Instances.Blade.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d30f6847-b67a-4dec-85ce-d837387081bb"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd75878f-c0c2-4b28-b90b-efb3dfae51a0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
