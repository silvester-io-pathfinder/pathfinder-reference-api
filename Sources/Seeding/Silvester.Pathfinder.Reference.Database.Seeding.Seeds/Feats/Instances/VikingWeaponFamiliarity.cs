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
    public class VikingWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("d60bb68a-ed5d-487c-8f0e-7d6a6ad738f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("28a01164-e775-4600-ad54-f2bbbe02827e"), Type = TextBlockType.Text, Text = $"From childhood, you have been exposed to traditional viking weapons, and you soon learned to handle them in battle. Now, you can raid proudly alongside your fellows. You are trained with the {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("battle axe", Items.MeleeWeapons.Instances.BattleAxe.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("hatchet", Items.MeleeWeapons.Instances.Hatchet.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longsword", Items.MeleeWeapons.Instances.Longsword.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("shortsword", Items.MeleeWeapons.Instances.Shortsword.ID)}. In addition, you gain the {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)} reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1cc53215-1610-4a09-b970-d8e5de292282"), Feats.Instances.VikingDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd01f219-7691-472d-bc18-45e15ce63965"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
