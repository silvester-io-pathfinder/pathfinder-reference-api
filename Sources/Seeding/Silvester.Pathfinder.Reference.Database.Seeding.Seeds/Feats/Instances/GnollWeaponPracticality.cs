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
    public class GnollWeaponPracticality : Template
    {
        public static readonly Guid ID = Guid.Parse("873f8301-08a8-4078-a707-c7aea4987046");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnoll Weapon Practicality",
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
            yield return new TextBlock { Id = Guid.Parse("733eb9b6-2251-4e72-98e7-8512f957c1dd"), Type = TextBlockType.Text, Text = $"Whenever you critically hit using {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("flails", Items.MeleeWeapons.Instances.Flail.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("khopeshes", Items.MeleeWeapons.Instances.Khopesh.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("mambeles", Items.MeleeWeapons.Instances.Mambele.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spears", Items.MeleeWeapons.Instances.Spear.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("war flails", Items.MeleeWeapons.Instances.WarFlail.ID)}, you apply the weapon's critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("69f159f9-698f-467d-9c28-b8dc960284b4"), Feats.Instances.GnollWeaponFamiliarity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ed6a3e6-326a-48ab-aae4-78a8a6f68861"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
