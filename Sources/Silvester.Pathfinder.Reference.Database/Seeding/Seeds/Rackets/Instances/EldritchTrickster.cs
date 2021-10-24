using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets.Instances
{
    public class EldritchTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Racket GetRacket()
        {
            return new Racket
            {
                Id = ID, 
                Name = "Eldritch Trickster",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When it comes to a big heist, every rogue worth their salt knows that magic can throw meticulous plans into chaos, whether in the form of arcane wards or pesky divinations. You dabble in magic just enough to help handle these problems by jury-rigging spells and throwing a bit of your own magic into the mix. You might be a solitary thief, performing burglaries that can't be explained by skill alone, or a specialist called in by other rogues to deal with magical security measures. You might even be on the up-and-up, hired to test magical defenses or even build them yourself." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose a multiclass archetype that has a basic, expert, and master spellcasting feat. You gain that archetype's dedication feat as a bonus feat even though you don't meet its level prerequisite, though you must meet its other prerequisites. For you, the Magical Trickster rogue feat has a prerequisite of 2nd level instead of 4th level. You can choose the spellcasting ability score for the multiclass archetype you chose as your key ability score." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.BardDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.BardDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Charisma.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.ClericDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ClericDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Wisdom.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.DruidDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DruidDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Wisdom.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.MagusDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.MagusDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.OracleDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.OracleDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Charisma.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.SorcererDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SorcererDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Charisma.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.WitchDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.WitchDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.WizardDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.WizardDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                });
            });
         
            builder.ModifyFeatLevelPrerequisite(Guid.Parse(""), Feats.Instances.MagicalTrickster.ID, ModifierType.Subtract, modifier: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 134
            };
        }
    }
}
