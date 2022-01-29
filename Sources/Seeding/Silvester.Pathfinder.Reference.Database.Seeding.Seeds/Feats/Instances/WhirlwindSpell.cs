using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("99a43940-19e0-4d0a-befb-a5a854239248");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Spell",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c93beec9-e918-4643-b0f1-44e35ea93062"), Type = TextBlockType.Text, Text = $"You combine the might of a multitarget spell with a whirling flurry of attacks. You use {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}, making a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against each enemy within your reach instead of against one enemy. If your spell can affect multiple targets, your spell affects all foes you hit, not just the first target, up to the spell's normal maximum targets. If you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} more foes than the spell could target, choose which foes are affected by the spell. Each attack counts toward your multiple attack penalty but doesn't increase your penalty until you've made all your attacks." };
            yield return new TextBlock { Id = Guid.Parse("8077f947-e1a3-4e06-8741-81c759c6d3c7"), Type = TextBlockType.Text, Text = $"If you use {ToMarkdownLink<Models.Entities.Feat>("Expansive Spellstrike", Feats.Instances.ExpansiveSpellstrike.ID)} to {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} with an area spell, apply the area as described in {ToMarkdownLink<Models.Entities.Feat>("Expansive Spellstrike", Feats.Instances.ExpansiveSpellstrike.ID)}, choosing one of the creatures you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} to determine the area and whether the spell fails due to a critically failed Strike. If you use {ToMarkdownLink<Models.Entities.Feat>("Expansive Spellstrike", Feats.Instances.ExpansiveSpellstrike.ID)} to {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} with a targeted spell, each creature you critically fail to {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is unaffected by the spell, but the spell isn't lost completely from a single critical failure." };
            yield return new TextBlock { Id = Guid.Parse("d5965143-da68-4955-b1eb-196f71a85863"), Type = TextBlockType.Text, Text = $"You can use this activity with only melee {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, even if you have the starlit span hybrid study or a similar ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc5107e6-b446-4c30-a0e5-1c5bd2e4cec5"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ad762bc-6207-4f0e-8387-1eaedfb89ee0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
