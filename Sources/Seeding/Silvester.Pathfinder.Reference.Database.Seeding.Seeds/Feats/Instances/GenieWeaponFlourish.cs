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
    public class GenieWeaponFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("4c7f85e9-f2f3-462b-aefa-5afcb9e17d22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Genie Weapon Flourish",
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
            yield return new TextBlock { Id = Guid.Parse("0f92af64-1e15-48eb-963a-ea10b02dacf3"), Type = TextBlockType.Text, Text = $"Whenever you critically hit using a {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("falchion", Items.MeleeWeapons.Instances.Falchion.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("ranseur", Items.MeleeWeapons.Instances.Ranseur.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scimitar", Items.MeleeWeapons.Instances.Scimitar.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("trident", Items.MeleeWeapons.Instances.Trident.ID)}, or a {ToMarkdownLink<Models.Entities.Trait>("geniekin", Traits.Instances.Geniekin.ID)} weapon, you apply the weapon's critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aa6af4ac-e0b7-49e9-81a6-74df4b0e7915"), Feats.Instances.GenieWeaponFamiliarity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("40ba24bb-6c44-4f8c-b27c-dac34cf01eee"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("7f3327ba-2035-4b96-ae24-37469e6e76f2"), Traits.Instances.Oread.ID);
            builder.Add(Guid.Parse("7d87c68f-f696-4596-9f6f-d9e8bcf2e090"), Traits.Instances.Suli.ID);
            builder.Add(Guid.Parse("8dcf0c75-4564-4d14-8981-bc98754c8805"), Traits.Instances.Sylph.ID);
            builder.Add(Guid.Parse("5737ae7f-900e-4b29-96d1-4567db6d05ea"), Traits.Instances.Undine.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cda5ebb5-3d7d-4412-84f7-7a494af6bb40"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
