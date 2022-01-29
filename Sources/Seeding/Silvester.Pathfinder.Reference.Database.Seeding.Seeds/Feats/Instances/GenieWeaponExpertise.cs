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
    public class GenieWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("4d2ae7f1-7d70-4263-aa61-7df3472e9a21");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Genie Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4900f77-0165-4493-be44-b1dc1969cf60"), Type = TextBlockType.Text, Text = $"Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("falchions", Items.MeleeWeapons.Instances.Falchion.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("ranseurs", Items.MeleeWeapons.Instances.Ranseur.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scimitars", Items.MeleeWeapons.Instances.Scimitar.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("tridents", Items.MeleeWeapons.Instances.Trident.ID)}, and all {ToMarkdownLink<Models.Entities.Trait>("geniekin", Traits.Instances.Geniekin.ID)} weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0bf3cf34-af8c-4f95-bebd-5a3bbd3a6e79"), Feats.Instances.GenieWeaponFamiliarity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c72910dc-a26e-4e3d-9d60-28c8c70bf955"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("ef61c5fe-0ebf-4fe2-888f-4ae58207cfd8"), Traits.Instances.Oread.ID);
            builder.Add(Guid.Parse("8c4c9a45-eeae-49d1-ae3f-bf7bcce23f0f"), Traits.Instances.Suli.ID);
            builder.Add(Guid.Parse("7b354ba0-483e-46ef-b0a5-1234d21f03bc"), Traits.Instances.Sylph.ID);
            builder.Add(Guid.Parse("dfb6128b-c343-48f8-a4be-f46f97f45362"), Traits.Instances.Undine.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c83e5ce8-ace3-402c-8012-613ca254f8e8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
